@extends('layout')
<?php $title = "Historia operacji"; 

?>

@section('content')
        <table class="table table-striped" >
            <thead>
                <tr>
                    <th>Data</th>
                    <th>PID</th>
                    <th>Czynnosc</th>
                    <th>Opis</th>
                </tr>
            </thead>
            <tbody>
            @foreach ($historia as $row)
              @if($row->czynnosc == "Edycja produktu")
              <tr id="{{ $row->id }}">
                <th scope="row">{{ $row->created_at }}</th>
                <td class="pid">{{ $row->pid }}</td>
                <td>{{ $row->czynnosc }}</td>
<!--                 Tabela w opisie -->
                <td>
                <?php 
                  //Kod ustawiający dane new i old
                  $getId=DB::table('produkty')->where('pid', $row->pid)->pluck('id');
                  $getId=$getId[0];
                  $old = DB::table('historiaProduktow')->where('id', $row->stary)->first();
                  $new = DB::table('historiaProduktow')->where('id', $row->nowy)->first();
                  ?>
        Operator zedytował produkt o PID <a href="szczegoly/{{$getId}}" class="pid">"{{$new->pid}}"</a> <br/>
        
<button type="button" data-toggle="collapse" data-target="#product-{{ $row->id }}" aria-expanded="false" aria-controls="collapseExample">Pokaż Szczegóły</button>
                  
<div class="collapse" id="product-{{ $row->id }}">
           <table  name="tabela-historii" class="table table-bordered history-table"><thead><tr><th>Kategoria</th><th>Z</th><th>Na</th></tr></thead><tbody><tr><th>Nazwa</th><td>{{ $old->nazwa }}</td><td>{{ $new->nazwa }}</td></tr><tr><th>Producent</th><td>{{ $old->producent }}</td><td>{{ $new->producent }}</td></tr><tr><th>Aleja</th><td>{{ $old->aleja }}</td><td>{{ $new->aleja }}</td></tr><tr><th>Box</th><td>{{ $old->box }}</td><td>{{ $new->box }}</td></tr><tr><th>Pozycja</th><td>{{ $old->pozycja }}</td><td>{{ $new->pozycja }}</td></tr><tr><th>Ilosc</th><td>{{ $old->ilosc }}</td><td>{{ $new->ilosc }}</td></tr><tr><th>Model</th><td>{{ $old->model }}</td><td>{{ $new->model }}</td></tr><tr><th>Rozmiar</th><td>{{ $old->rozmiar }}</td><td>{{ $new->rozmiar }}</td></tr><tr><th>Typ</th><td>{{ $old->typ }}</td><td>{{ $new->typ }}</td></tr><tr><th>Opis</th><td>{{ $old->opis }}</td><td>{{ $new->opis }}</td></tr></tbody></table>
</div>
                
                </td>
              </tr>
              @else
                <tr id="{{ $row->id }}">
                    <th scope="row">{{ $row->created_at }}</th>
                  <td class="pid">{{ $row->pid }}</td>
                    <td>{{ $row->czynnosc }}</td>
<!--         W opisie robisz tablice gdzie w przypadku aktualizacji po lewej stronie zapisujesz stare wartosci a po prawej nowe.           -->
                    <td>{{$row->opis}}</td>
                </tr>
              @endif
            @endforeach
            </tbody>
        </table>
</div>
              <script type="text/javascript">
              $('button').click(function(){
    $(this).text(function(i,tekst){
        return tekst=='Pokaż Szczegóły' ?  'Ukryj Szczegóły' : 'Pokaż Szczegóły';
    });
        });
              </script>
@stop