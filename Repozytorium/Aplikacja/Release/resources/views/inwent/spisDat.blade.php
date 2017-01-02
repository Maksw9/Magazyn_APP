@extends('layout')
<?php 
$title = "Inwentaryzacja - Historia"; 
?>

@section('content')

    <table class="table table-striped" id="tbl1">
            <thead>
                <tr>
                    <th>#</th>
                    <th>ID</th>
                    <th>Nazwa</th>
                    <th>Producent</th>
                    <th>Aleja</th>
                    <th>Box</th>
                    <th>Pozycja</th>
                    <th>Wiecej / <a href="/inwent/xml">Generuj XML</a></th>
                </tr>
            </thead>
            <tbody>
            @foreach ($historia as $produkt)
                <tr id="{{$produkt->id}}">
                    <td scope="row">{{$produkt->id}}</td>
                    <td class="pid">{{ $produkt->pid }}</td>
                    <td><a href="/szczegoly/{{ $produkt->id }}">{{ $produkt->nazwa }}</a></td>
                    <td>{{ $produkt->producent }}</td>
                    <td>{{ $produkt->aleja }}</td>
                    <td>{{ $produkt->box }}</td>
                    <td>{{ $produkt->pozycja }}</td>
                    <td><a href="/inwent/historia/{{ $produkt->id }}">Historia inwentaryzacji produktu</a></td>
                    <td><input style="visibility:hidden" type="checkbox"></td>
                </tr>
            @endforeach
            </tbody>
        </table>
@stop