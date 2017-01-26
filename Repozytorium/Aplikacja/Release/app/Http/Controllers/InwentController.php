<?php
namespace App\Http\Controllers;
use Spatie\ArrayToXml\ArrayToXml;
use App\Inwent;
use Validator;
use App\InwentRemember;
use App\Produkt;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Http\Requests;

class InwentController extends Controller
{
	
	public function lista(Request $req){
		if($req->input('cancelAction') == "Anuluj"){
			InwentRemember::truncate();
		}
		$produkty = Produkt::all();
		if(InwentRemember::first()==null)
		$zapamietane=false;
		else
			$zapamietane=true;
		$remem=null;
    return view('inwent.lista', compact('produkty', 'zapamietane', 'remem'));
	}
  
	public function obslugaZapamietywania(Request $request){
		if($request->input('subm') == "Cofnij zmiany"){
			return redirect('inwent');
		}
		
		//pobranie wartosci wszystkich ilosci
		$input=$request->all();
		$produkty=Produkt::all();
		$count=DB::table('produkty')->count();
		if($request->input('zapamietaj')){
			InwentRemember::truncate();
		}
		for($i=0;$i<$count;$i++){
					$rem= new InwentRemember;
					$rem->idProd = $produkty[$i]->id;
					$rem->ilosc = $input['ilosc'][$i];
					$rem->save();
				
		}
		$remem=InwentRemember::all();
			$zapamietane=true;
		return view('inwent.lista', compact('produkty', 'zapamietane', 'remem'));
	}
	public function inwentaryzacja($id)
	{
		$produkt = Produkt::where('id', $id)->first();
		$inw = Inwent::where('id', $id)->orderBy('created_at', 'desc')->get();
		InwentController::generujXML($inw);
		return view('inwent.historiaProduktu', compact('produkt', 'inw'));
	}

	public function inwentaryzacjaZapisz(Request $request)
	{
		$messages = [
    'numeric' => 'Ilosc musi byc liczba.',
    'min' => 'Ilosc musi miec wartosc przynajmniej 0.',
    'max' => 'Ilosc musi miec co najwyzej 999999.',
];

		
		  $validator = Validator::make($request->all(), [
						'ilosc.*' => 'numeric|min:0|max:999999',
        ], $messages);

        if ($validator->fails()) {
            return redirect('inwent')->withErrors($validator)->withInput();
        }
		//pobranie wartosci wszystkich ilosci
		$input=$request->all();
		$produkty=Produkt::all();
		$count=DB::table('produkty')->count();
		$produkt=array();
		$stare=array();
		$nowe=array();
		$roznica=array();
		for($i=0;$i<$count;$i++){
			//w ifie zmiany zostana wprowadzone tylko tam gdzie sie ilosc zmienila
			if($produkty[$i]->ilosc != $input['ilosc'][$i]){
				//Znaleziono zmieniony rekord, czas zapisac zmiany
		$old=$produkty[$i];
				//pozyskanie id starego elementu (do stworzenia podsumowania)
				$tmp=Inwent::insertGetId(['id' => $old->id, 'pid' => $old->pid, 'nazwa' => $old->nazwa, 'producent' => $old->producent, 'aleja' => $old->aleja, 'box' => $old->box, 'pozycja' => $old->pozycja, 'ilosc' => $old->ilosc, 'model' => $old->model, 'rozmiar' => $old->rozmiar, 'typ' => $old->typ, 'opis' => $old->opis, 'created_at' => date('Y-m-d H:i:s') ]);
				Produkt::where('id', $produkty[$i]->id)->update([ 'ilosc' => $input['ilosc'][$i]]);
				$cnt=$input['ilosc'][$i]-$produkty[$i]->ilosc;
				array_push($produkt, $old);
				array_push($stare, $produkty[$i]->ilosc);
				array_push($nowe, $input['ilosc'][$i]);
				array_push($roznica, $cnt);
			}
			
		}
		session()->put($stare);
		if(empty($produkt)){
			$produkt=NULL;
			$stare=NULL;
			$nowe=NULL;
			$roznica=NULL;
		}
		InwentRemember::truncate();
		return view('inwent.podsumowanie', compact('produkt','stare','nowe','roznica'));
	}
	
	
public function historia(){
		$produkty = Inwent::orderBy('created_at')->get();
		InwentController::generujXML($produkty);
		$dataArray = array();
		$flaga = 0;
		
    foreach($produkty as $produkt){
    	$data = explode(" ", $produkt->created_at);
			array_push($dataArray, $data[0]);
		}
		$result = array_unique($dataArray);
    return view('inwent.historia', ['historia'=>$result]);
	}
	
public function inwentaryzacjaSpisDat($data){
		$lista = Inwent::whereDate('created_at', '=', date($data))->get();
		InwentController::generujXML($lista);
		return view('inwent.spisDat', ['historia'=>$lista]);
	}
	
private static function generujXML($tablica){
		$base_path = base_path();
		$path = $base_path."/storage/app/inwentaryzacja.xml";

		$xml = new \SimpleXMLElement('<produkt_info/>');
		InwentController::to_xml($xml, $tablica->toArray());

		//Format XML to save indented tree rather than one line
		$dom = new \DOMDocument('1.0');
		$dom->preserveWhiteSpace = false;
		$dom->formatOutput = true;
		$dom->loadXML($xml->asXML());
		//Echo XML - remove this and following line if echo not desired
		$dom->saveXML();
		//Save XML to file - remove this and following line if save not desired
		$dom->save($path);
}


private static function to_xml(\SimpleXMLElement $object, array $data)
{   
    foreach ($data as $key => $value) {
        if (is_array($value)) {
            $new_object = $object->addChild('produkt'.$key);
            InwentController::to_xml($new_object, $value);
        } else {   
            $object->addChild($key,htmlspecialchars($value));
        }   
    }   
}   
	
public function inwentaryzacjaPobierzXML(){
	$base_path = base_path();
	$path = $base_path."/storage/app/inwentaryzacja.xml";
	return response()->download($path);
}

	
		public function zaladujPoprzednie(){
			$produkty= Produkt::all();
			$remem=InwentRemember::all();
		$zapamietane=false;	
			return view('inwent.lista', compact('produkty', 'zapamietane', 'remem'));
		}
	
}