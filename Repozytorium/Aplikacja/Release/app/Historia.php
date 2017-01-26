<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

/**
 * @property integer $id
 * @property string $pid
 * @property string $nazwa
 * @property string $producent
 * @property integer $aleja
 * @property integer $pozycja
 * @property integer $box
 * @property integer $ilosc
 * @property string $typ
 * @property string $model
 * @property float $rozmiar
 * @property string $opis
 * @property string $created_at
 * @property string $updated_at
 */
class Historia extends Model
{
    /**
     * The table associated with the model.
     * 
     * @var string
     */
    protected $table = 'historia';

    /**
     * @var array
     */
    protected $fillable = ['id', 'pid', 'czynnosc', 'opis', 'stary', 'nowy', 'created_at', 'updated_at'];

}
