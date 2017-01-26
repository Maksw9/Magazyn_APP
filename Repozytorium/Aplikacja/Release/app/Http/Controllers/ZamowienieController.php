<?php
namespace App\Http\Controllers;
use Spatie\ArrayToXml\ArrayToXml;
use App\Produkt;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use App\Http\Requests;

class ZamowienieController extends Controller
{
	
	public function zlozZamowienie(){
		$produkty = Produkt::all();
    return view('zamowienie.zamow', compact('produkty'));
	}
}