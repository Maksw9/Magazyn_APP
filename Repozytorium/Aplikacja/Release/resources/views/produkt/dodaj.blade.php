@extends('layout')
<?php 

  
$title = "Dodaj produkt"; 

?>
@section('content')

@if (count($errors) > 0)
    <div class="alert alert-danger">
        <ul>
            @foreach ($errors->all() as $error)
                <li>{{ $error }}</li>
            @endforeach
        </ul>
    </div>
@endif;

            <div class="form">
                <form action="{{ url('/') }}/produkt/zapisz" method="post">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Nazwa</label>
                    <input type="text" class="form-control" name="nazwa">
                    <label for="exampleInputEmail1">Producent</label>
                    <input type="text" class="form-control" name="producent">
                    <label for="exampleInputEmail1">Aleja</label>
                    <input type="text" class="form-control" name="aleja">
                    <label for="exampleInputEmail1">Box</label>
                    <input type="text" class="form-control" name="box">
                    <label for="exampleInputEmail1">Pozycja</label>
                    <input type="text" class="form-control" name="pozycja">
                    <label for="exampleInputEmail1">Ilość</label>
                    <input type="text" class="form-control" name="ilosc">
                    <label for="typ">Typ</label>
                    <select class="form-control" name="typ">
                     <option name="meskie" style="font-weight:bold;">Męskie</option>
                     <option name="damskie" style="font-weight:bold;">Damskie</option>
                    </select>
                    <label for="exampleInputEmail1">Model</label>
                    <input type="text" class="form-control" name="model">
                    <label for="exampleInputEmail1">Rozmiar</label>
                    <input type="text" class="form-control" name="rozmiar">
                    <label for="exampleInputEmail1">Opis</label>
                    <input type="text" class="form-control" name="opis">
                  </div>
                  <div class="form-group">
                    <input type="submit" class="btn btn-default" name="Zapisz" value="Zapisz" />
                  <a href="/"><button type="button" class="btn btn-default">Cofnij</button></a>
                  </div>
                  
              </form>
            </div>
        </div>
        
@stop