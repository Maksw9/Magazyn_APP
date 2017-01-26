<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateInwetTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('inwent', function (Blueprint $table){
         $table->increments('id_inwent');
         $table->integer('id');
         $table->string('pid');
         $table->string('nazwa');
            $table->string('producent');
            $table->integer('aleja');
            $table->integer('pozycja');
            $table->integer('box');
            $table->integer('ilosc');
            $table->string('typ');
            $table->string('model');
            $table->float('rozmiar');
            $table->string('opis');
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('inwent');
    }
}
