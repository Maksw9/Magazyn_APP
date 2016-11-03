@extends('layout')
<?php $title="Szczegóły"; ?>
@section('content')
        <table class="table table-striped">
            <thead>
                <tr>
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
                    <th>Wiecej</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope="row">{{ $produkt->id }}</th>
                    <td>{{ $produkt->nazwa }}</a></td>
                    <td>{{ $produkt->producent }}</td>
                    <td>{{ $produkt->aleja }}</td>
                    <td>{{ $produkt->box }}</td>
                    <td>{{ $produkt->pozycja }}</td>
                    <td>{{ $produkt->ilosc }}</td>
                    <td>{{ $produkt->typ }}</td>
                    <td>{{ $produkt->model }}</td>
                    <td>{{ $produkt->rozmiar }}</td>
                    <td><a href="/edytuj/{{ $produkt->id }}">Edytuj</a></td>
                </tr>
            </tbody>
        </table>
@stop