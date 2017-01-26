<?php

/*
|--------------------------------------------------------------------------
| Routes File
|--------------------------------------------------------------------------
|
| Here is where you will register all of the routes in an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/

//Lista
Route::get('/', 'ProduktController@lista');
//Produkt
Route::get('produkt/szczegoly/{id}', 'ProduktController@szczegoly');
Route::get('produkt/edytuj/{id}', 'ProduktController@edytuj');
Route::post('produkt/aktualizuj/{id}', 'ProduktController@aktualizuj');
//Historia
Route::get('produkt/historia', 'ProduktController@historia');
//Inwentaryzacja
Route::get('inwent/historia/{id}', 'InwentController@inwentaryzacja');
Route::get('inwent/historia/data/{data}', 'InwentController@inwentaryzacjaSpisDat');
Route::get('inwent/xml', 'InwentController@inwentaryzacjaPobierzXML');

//Route::get('inwent/temp', 'InwentController@inwetaryzacjaTemps');


/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| This route group applies the "web" middleware group to every route
| it contains. The "web" middleware group is defined in your HTTP
| kernel and includes session state, CSRF protection, and more.
|
*/
Route::group(['middleware' => ['validation']], function(){
  // Tutaj formularze poddane walidacji
  //Produkt
  Route::get('produkt/dodaj', 'ProduktController@dodaj');
  Route::get('zamowienie/zamow', 'ZamowienieController@zlozZamowienie');
  Route::post('produkt/zapisz', 'ProduktController@zapisz');
  //Inwentaryzacja
  Route::any('inwent', 'InwentController@lista');
Route::get('inwent/load', 'InwentController@zaladujPoprzednie');
  Route::get('inwent/historia', 'InwentController@historia');
  Route::post('inwent/podsumowanie', 'InwentController@inwentaryzacjaZapisz');
Route::post('inwent/remember', 'InwentController@obslugaZapamietywania');
});


Route::group(['middleware' => ['web']], function () {
});

