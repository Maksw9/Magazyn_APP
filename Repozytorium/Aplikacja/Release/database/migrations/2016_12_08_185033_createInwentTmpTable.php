<?php

use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateInwentTmpTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('inwentRemember', function (Blueprint $table) {
            $table->increments('id');
            $table->integer('idProd');
            $table->integer('ilosc');
            $table->timestamps();
        }
        //
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('inwentRemember');
        //
    }
}
