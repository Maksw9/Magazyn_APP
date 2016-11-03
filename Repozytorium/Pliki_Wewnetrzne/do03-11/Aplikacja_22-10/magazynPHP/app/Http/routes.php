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

Route::get('/', 'PagesController@welcome');
Route::get('szczegoly/{id}', 'PagesController@szczegoly');
Route::get('edytuj/{id}', 'PagesController@edytuj');
Route::post('aktualizuj/{id}', 'PagesController@aktualizuj');

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
Route::get('dodaj', 'PagesController@dodaj');
Route::post('zapisz', 'PagesController@zapisz');
});


Route::group(['middleware' => ['web']], function () {
});

