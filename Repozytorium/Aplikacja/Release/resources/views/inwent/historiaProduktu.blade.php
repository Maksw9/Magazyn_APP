@extends('layout')
<?php $title="Historia inwentaryzacji produktu"; ?>
@section('content')


        <table class="table table-striped">
          <caption>Aktualny produkt</caption>
            <thead>
                <tr>
                    <th>#</th>
                    <th>ID</th>
                    <th>Nazwa</th>
                    <th>Producent</th>
                    <th>Aleja</th>
                    <th>Box</th>
                    <th>Pozycja</th>
                    <th>Ilosc</th>
                    <th>Typ</th>
                    <th>Model</th>
                    <th>Rozmiar</th>
                    <th>Opis</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">{{$produkt->id}}</th>
                    <th class="pid" id="{{$produkt->id}}">{{ $produkt->pid }}</th>
                    <td>{{ $produkt->nazwa }}</a></td>
                    <td>{{ $produkt->producent }}</td>
                    <td>{{ $produkt->aleja }}</td>
                    <td>{{ $produkt->box }}</td>
                    <td>{{ $produkt->pozycja }}</td>
                    <td>{{ $produkt->ilosc }}</td>
                    <td>{{ $produkt->typ }}</td>
                    <td>{{ $produkt->model }}</td>
                    <td>{{ $produkt->rozmiar }}</td>
                    <td>{{ $produkt->opis }}</td>
                </tr>
            </tbody> 
<table class="table table-striped">
          <caption>Historia inwentaryzacji produktu / <a href="/inwent/xml">Generuj XML</a></caption>
  <thead>
                <tr>
                    <th>Data</th>
                    <th>ID</th>
                    <th>Nazwa</th>
                    <th>Producent</th>
                    <th>Aleja</th>
                    <th>Box</th>
                    <th>Pozycja</th>
                    <th>Ilosc</th>
                    <th>Typ</th>
                    <th>Model</th>
                    <th>Rozmiar</th>
                    <th>Opis</th>
                </tr>
  
  </thead>
  <tbody>
    
               
@foreach($inw as $inwent)
<tr>
    <th>{{$inwent->created_at}}</th>
    <td class="pid">{{$inwent->pid}}</td>
    <td>{{$inwent->nazwa}}</td>
    <td>{{$inwent->producent}}</td>
    <td>{{$inwent->aleja}}</td>
    <td>{{$inwent->box}}</td>
    <td>{{$inwent->pozycja}}</td>
    <td>{{$inwent->ilosc}}</td>
    <td>{{$inwent->typ}}</td>
    <td>{{$inwent->model}}</td>
    <td>{{$inwent->rozmiar}}</td>
    <td>{{$inwent->opis}}</td>
    </tr>
@endforeach
  </tbody>
</table>

@stop