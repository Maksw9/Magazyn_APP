<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateProductsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('produkty', function (Blueprint $table) {
            $table->increments('id');
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
        Schema::dropIfExists('produkty');
    }
}
