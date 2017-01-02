@extends('layout')
<?php $title = "Inwentaryzacja - Daty"; ?>

@section('content')
@if (count($errors) > 0)
    <div class="alert alert-danger">
        <ul>
            @foreach ($errors->all() as $error)
                <li>{{ $error }}</li>
            @endforeach
        </ul>
    </div>
@endif
    <table class="table table-striped" id="tbl1">
            <thead>
                <tr>
                    <th>Data inwentaryzacji</th>
                    <th>Więcej / <a href="/inwent/xml">Generuj XML</a></th>
                </tr>
            </thead>
            <tbody>
            <?php
              foreach($historia as $data){
              ?>
                <tr>
                     <td>{{ $data }}</td>              
                     <td><a href="/inwent/historia/data/{{ $data }}">Historia inwentaryzacji z dnia</a></td>
                  </tr>
            <?php
                }
              ?>
            </tbody>
        </table>
@stop