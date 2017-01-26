<?php
namespace App\Http\Controllers;
use App\Produkt;
use App\Inwent;
use App\Historia;
use App\HistoriaProduktow;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Http\Requests;
use Illuminate\Support\Facades\Redirect;

class ProduktController extends Controller
{

	
	public function lista(){
			$produkty = Produkt::all();
      return view('produkt.lista', ['produkty'=>$produkty]);
   }
	
  public function edytuj($id)
	{
		$produkt = Produkt::where('id', $id)->first();
		return view('produkt.edytuj', ['produkt' => $produkt]);
	}
	
  public function szczegoly($id)
	{
		$produkt = Produkt::where('id', $id)->first();
		return view('produkt.szczegoly', ['produkt' => $produkt]);
	}
	
  public function aktualizuj($id, Request $request)
	{
		$produkt = new Produkt;
		$old = Produkt::find($id);
		$produkt = Produkt::find($id);
		$input = $request->all();
    $produkt->fill($input);
    $produkt->save();
		
		$historiaProduktu = new HistoriaProduktow;
		$old = $old->toArray();
		$historiaProduktu->fill($old);
		$historiaProduktu->save();
		$oldID = $historiaProduktu->id;
		
		$historiaProduktu->fill($input);
		$historiaProduktu->pid = $old['pid'];
		$historiaProduktu->save();
		$newID = $historiaProduktu->id;
		
		$historia = new Historia;
		$historia->czynnosc = 'Edycja produktu';
		$historia->pid = $old['pid'];
		$historia->stary = $oldID;
		$historia->nowy = $newID;
		$historia->save();		
		return redirect('produkt/szczegoly/' . $id);
	}
	
  public function dodaj()
	{
		return view("produkt.dodaj");
	}
	
	public function historia(){
      $historia = Historia::orderBy('created_at', 'desc')->get();
      return view('produkt.historia', compact('historia'));
    }
	
  public function zapisz(Request $request)
	{
		$produkt = new Produkt; 
		
		$validator = \Validator::make($request->all(), [
        'nazwa' => 'required|min:3|max:64', 
        'producent' => 'required|min:1|max:32', 
        'aleja' => 'required|min:1|max:5|regex:/^[a-zA-Z1-9]+$/', 
        'box' => 'required|min:1|max:5|regex:/^[a-zA-Z1-9]+$/', 
        'pozycja' => 'required|numeric|min:1|max:999', 
        'ilosc' => 'numeric|min:1|max:999999', 
        'model' => 'required|min:3|max:64', 
        'rozmiar' => ['required', 'numeric', 'max:100', 'regex:/^((\d{1,3}.\d)|(\d{1,3}))+$/'], 
        'opis' => 'max:12000'
        ]);

    if ($validator->fails()) {
            return redirect('produkt/dodaj')
                        ->withErrors($validator)
                        ->withInput();
    }
		$produkt = new Produkt;
		$input = $request->all();
    $produkt->fill($input);
    $produkt->save();
		$id = $produkt->id;
		//$id = Produkt::insertGetId(['nazwa' => $request->input('nazwa') , 'producent' => $request->input('producent') , 'aleja' => $request->input('aleja') , 'box' => $request->input('box') , 'pozycja' => $request->input('pozycja') , 'ilosc' => $request->input('ilosc') , 'model' => $request->input('model') , 'rozmiar' => $request->input('rozmiar') , 'typ' => $request->input('typ') , 'opis' => $request->input('opis') ]);
		// insert () - dodaje do tabeli rekord - klasycznie
		// insertGetId() - dodaje do tabeli rekord i wyciąga 'id'c rekordu
		$char1 = mb_substr($request->nazwa, 0, 1); //wyciąga 1 litere z nazwy
		$char2 = mb_substr($request->model, 0, 1);
		$char3 = mb_substr($request->producent, 0, 1);
		$char4 = ($id * 1679979167) % (1000);
		if ($char4 < 100 && $char4 > 9) $char4 = "0$char4";
		if ($char4 < 10) $char4 = "00$char4";
		$count = Produkt::where('pid', "$char1$char2$char3$char4")->count();
		while ($count != 0) {
			$char4 = ($char4 * 1679979167 * $id) % (1000);
			if ($char4 < 100 && $char4 > 9) $char4 = "0$char4";
			if ($char4 < 10) $char4 = "00$char4";
			$count = Produkt::where('pid', "$char1$char2$char3$char4")->count();
		}
		Produkt::where('id', $id)->update(['pid' => "$char1$char2$char3$char4"]);
		$produkt = Produkt::where('id', $id)->first();
		Historia::insert(['czynnosc' => 'Dodawanie produktu', 'pid' => $produkt->pid, 'opis' => 'Dodanie produktu o PID: ' . $produkt->pid, 'created_at' => date('Y-m-d H:i:s') , 'updated_at' => date('Y-m-d H:i:s') ]);
		return redirect('produkt/szczegoly/' . $id);
	}
}