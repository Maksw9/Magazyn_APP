@extends('layout')
<?php $title="Szczegoly"; ?>
@section('content')
        <table class="table table-striped">
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
                    <th>Wiecej</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">{{$produkt->id}}</th>
                    <th>{{ $produkt->pid }}</th>
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
                    <td><a href="/produkt/edytuj/{{ $produkt->id }}">Edytuj</a></td>
                </tr>
            </tbody>
        </table>
@stop