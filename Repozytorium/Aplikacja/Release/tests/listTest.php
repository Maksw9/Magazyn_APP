<?php

use Illuminate\Foundation\Testing\WithoutMiddleware;
use Illuminate\Foundation\Testing\DatabaseMigrations;
use Illuminate\Foundation\Testing\DatabaseTransactions;

class listTest extends TestCase
{
    /**
     * A basic functional test example.
     *
     * @return void
     */
    public function testListShow()
    {
        $this->visit('/')
             ->see('Magazyn');
    }
    
  public function testEdytuj(){
        $this->visit('/')
           ->click('Edytuj')
           ->seePageIs('/edytuj/1')->see('Edytuj produkt');
    }
  
    public function testSzczegoly(){
        $this->visit('/')
           ->click('Szczegoly')
           ->seePageIs('/szczegoly/1')->see('Szczegoly');
    }
}
