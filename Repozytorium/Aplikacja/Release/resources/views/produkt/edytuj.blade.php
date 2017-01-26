@extends('layout')
<?php $title="Edytuj produkt" ?>
@section('content')
            <div class="form">
                <form action="{{ url('/') }}/produkt/aktualizuj/{{ $produkt->id }}" method="post">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Nazwa</label>
                    <input type="text" class="form-control" name="nazwa" value="{{ $produkt->nazwa }}">
                    <label for="exampleInputEmail1">Producent</label>
                    <input type="text" class="form-control" name="producent" value="{{ $produkt->producent }}">
                    <label for="exampleInputEmail1">Aleja</label>
                    <input type="text" class="form-control" name="aleja" value="{{ $produkt->aleja }}">
                    <label for="exampleInputEmail1">Box</label>
                    <input type="text" class="form-control" name="box" value="{{ $produkt->box }}">
                    <label for="exampleInputEmail1">Pozycja</label>
                    <input type="text" class="form-control" name="pozycja" value="{{ $produkt->pozycja }}">
                    <label for="exampleInputEmail1">Ilość</label>
                    <input type="text" class="form-control" name="ilosc" value="{{ $produkt->ilosc }}">
                    <label for="typ">Typ</label>
                    <select class="form-control" name="typ">
                     <option style="font-weight:bold;" <?php if($produkt->typ == "Męskie") echo "selected"; ?>>Męskie</option>
                     <option style="font-weight:bold;" <?php if($produkt->typ == "Damskie") echo "selected"; ?>>Damskie</option>
                    </select>
                    <label for="exampleInputEmail1">Model</label>
                    <input type="text" class="form-control" name="model" value="{{ $produkt->model }}">
                    <label for="exampleInputEmail1">Rozmiar</label>
                    <input type="text" class="form-control" name="rozmiar" value="{{ $produkt->rozmiar }}">
                    <label for="exampleInputEmail1">Opis</label>
                    <input type="text" class="form-control" name="opis" value="{{ $produkt->opis }}">
                  </div>
                  <button type="submit" class="btn btn-default">Zapisz</button>
              </form>
            </div>
        </div>
        
@stop