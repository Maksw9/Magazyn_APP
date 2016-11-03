<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Http\Requests;

class PagesController extends Controller
{
    public function welcome(){
      $produkty = DB::table('produkty')->get();
      return view('welcome', ['produkty'=>$produkty]);
    }
  
  public function edytuj($id){
    
    $produkt = DB::table('produkty')->where('id', $id)->first();
    return view('edytuj', ['produkt'=>$produkt]);
  }
  
  public function szczegoly($id){
    $produkt = DB::table('produkty')->where('id', $id)->first();
    return view('szczegoly', ['produkt'=>$produkt]);
  }
  
  public function aktualizuj($id, Request $request){
    DB::table('produkty')->where('id', $id)->update(['nazwa' => $request->input('nazwa'), 'producent' => $request->input('producent'), 
                                                    'aleja' => $request->input('aleja'), 'box' => $request->input('box'), 'pozycja' => $request->input('pozycja'),
                                                    'ilosc' => $request->input('ilosc'), 'model' => $request->input('model'), 'rozmiar' => $request->input('rozmiar'), 
                                                     'typ' => $request->input('typ')]);
    return redirect('szczegoly/'.$id);
  }
  public function dodaj(){
    return view("dodaj");
  }
  public function zapisz(Request $request){
     $this->validate($request, [
        'nazwa' => 'required',
        'producent' => 'required',
        'aleja' => 'required|numeric',
        'box' => 'required|numeric',
        'pozycja' => 'required|numeric',
        'ilosc' => 'required|numeric',
        'model' => 'required',
        'rozmiar' => 'required|numeric',
    ]);
      $id =  DB::table('produkty')->insertGetId(['nazwa' => $request->input('nazwa'), 'producent' => $request->input('producent'), 
                                   'aleja' => $request->input('aleja'), 'box' => $request->input('box'), 'pozycja' => $request->input('pozycja'),
                                   'ilosc' => $request->input('ilosc'), 'model' => $request->input('model'), 'rozmiar' => $request->input('rozmiar'), 'typ' => $request->input('typ')]);
      //insert () - dodaje do tabeli rekord - klasycznie
      //insertGetId() - dodaje do tabeli rekord i wyciąga 'id' rekordu
    return redirect('szczegoly/' . $id);
  }
}
