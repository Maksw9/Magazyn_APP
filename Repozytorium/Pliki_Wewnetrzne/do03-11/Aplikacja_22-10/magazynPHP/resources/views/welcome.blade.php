@extends('layout')
<?php $title = "Magazyn"; ?>

@section('content')
        <table class="table table-striped" id="tbl1">
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
            @foreach ($produkty as $produkt)
                <tr id="{{ $produkt->id }}">
                    <th scope="row">{{ $produkt->id }}</th>
                    <td><a href="/szczegoly/{{ $produkt->id }}">{{ $produkt->nazwa }}</a></td>
                    <td>{{ $produkt->producent }}</td>
                    <td>{{ $produkt->aleja }}</td>
                    <td>{{ $produkt->box }}</td>
                    <td>{{ $produkt->pozycja }}</td>
                    <td>{{ $produkt->ilosc }}</td>
                    <td>{{ $produkt->typ }}</td>
                    <td>{{ $produkt->model }}</td>
                    <td>{{ $produkt->rozmiar }}</td>
                    <td><a href="/edytuj/{{ $produkt->id }}">Edytuj</a> | <a href="/szczegoly/{{ $produkt->id }}">Szczegoly</a></td>
                </tr>
            @endforeach
            </tbody>
        </table>
    <script>
     $("#tbl1 tbody tr").bind("contextmenu",function(e) {
        e.preventDefault();
        $id = $(this).attr('id');
        document.getElementById("dialog-confirm").style.visibility = "visible";
       $( function() {
          $( "#dialog-confirm" ).dialog({
            resizable: false,
            height: "auto",
            width: 400,
            modal: true,
            buttons: {
              "Szczegoly": function() {
                window.location.href = "/szczegoly/"+$id;
              },
              "Edytuj": function() {
                window.location.href = "/edytuj/"+$id;
              },
              Cancel: function() {
                $( this ).dialog( "close" );
              }
            }
          });
        } );
      });
    </script>
    <div id="dialog-confirm" style="visibility:hidden;" title="Wybierz akcje na elemencie.">
      <p>Co chcesz zrobic z zaznaczonym rekordem?</p>
    </div>
@stop