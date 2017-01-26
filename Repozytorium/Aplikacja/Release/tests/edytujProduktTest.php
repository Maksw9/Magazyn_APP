<?php

use Illuminate\Foundation\Testing\WithoutMiddleware;
use Illuminate\Foundation\Testing\DatabaseMigrations;
use Illuminate\Foundation\Testing\DatabaseTransactions;

class edytujProduktTest extends TestCase
{
    /**
     * A basic test example.
     *
     * @return void
     */
    public function testEdytowanieProduktu()
    {
         $response = $this->call('POST', '/aktualizuj/1', ['nazwa'=>"Japonki",
        	'producent'=>"XinCompany",
        	'aleja'=>2,
        	'pozycja'=>5,
        	'box'=>2,
        	'ilosc'=>5,
        	'typ'=>'Męskie',
        	'model'=>"XX452XXS",
        	'rozmiar'=>35,
          'opis'=>'Prawdziwe najlepsze meskie buty'
          ]);
    }
  
  public function testFormularzEdytowaniaProduktu()
    {
      $this->visit('/edytuj/1')
         ->type('Najki', 'nazwa')
         ->type('Nikedaw', 'producent')
         ->type(23, 'aleja')
         ->type(12, 'pozycja')
         ->type(8, 'box')
         ->type(123, 'ilosc')
         ->select('Męskie', 'typ')
         ->type('Classic', 'model')
         ->type(333, 'rozmiar')
         ->type('Czarne, z białymi paskami......', 'opis')
         ->submitForm('Zapisz')->seePageIs('/szczegoly/1')
          ->seeInDatabase('produkty', ['producent' => 'XinCompany']);
    }
}
