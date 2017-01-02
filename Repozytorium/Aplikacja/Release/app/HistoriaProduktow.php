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
class HistoriaProduktow extends Model
{
    /**
     * The table associated with the model.
     * 
     * @var string
     */
    protected $table = 'historiaProduktow';

    /**
     * @var array
     */
    protected $fillable = ['pid', 'nazwa', 'producent', 'aleja', 'pozycja', 'box', 'ilosc', 'typ', 'model', 'rozmiar', 'opis', 'created_at', 'updated_at'];

}
