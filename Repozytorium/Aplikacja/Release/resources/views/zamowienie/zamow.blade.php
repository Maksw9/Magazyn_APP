@extends('layout')
<?php 

  
$title = "Złóż zamówienie"; 

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
                <form action="{{ url('/') }}/zamowienie/zapisz" method="post">
                  <div class="form-group">
                    <div class="panel panel-default">
  <div class="panel-heading">Tabela produktów</div>
  <div class="panel-body">
    <table class="datatables-table table table-striped table-bordered">
      <thead>
        <tr>
          <th>ID</th>
          <th>Nazwa</th>
          <th>Producent</th>
          <th>Ilosc</th>
          <th>Zamów</th>
        </tr>
      </thead>
      <tfoot>
        <tr>
          <th>ID</th>
          <th>Nazwa</th>
          <th>Producent</th>
          <th>Ilosc</th>
          <th>Zamów</th>
        </tr>
      </tfoot>
      <tbody>
        @foreach($produkty as $prod)
        <tr>
          <th scrope="row">{{$prod->pid}}</th>
          <td>{{$prod->nazwa}}</td>
          <td>{{$prod->producent}}</td>
          <td>{{$prod->ilosc}}</td>
          <td><input type="text" class="form-control" name="produkt-{{$prod->id}}"></td>
        </tr>
        @endforeach
      </tbody>
    </table>


  </div>
</div>
                  </div>
                  <div class="form-group">
                    <input type="submit" class="btn btn-primary" name="save" value="Złóż zamówienie" />
                  <a href="/"><button type="button" class="btn btn-default">Cofnij</button></a>
                  </div>
                  
              </form>
            </div>
        </div>
<script src="{{ URL::asset('js/datatable.js') }}"></script>
<script src="https://cdn.datatables.net/1.10.13/js/dataTables.bootstrap.min.js"></script>
      <script>
        $(function() {

        // Initialize DataTables
        $('.datatables-table').DataTable( {
        "language": {
    "decimal":        "",
    "emptyTable":     "Nie ma produktów",
    "info":           " _START_ - _END_ z _TOTAL_ rekordow",
    "infoEmpty":      "0 - 0 z 0 rekordow",
    "infoFiltered":   "(znaleziono sposrod _MAX_ produktow)",
    "infoPostFix":    "",
    "thousands":      ",",
    "lengthMenu":     "Pokaz _MENU_ naglowkow",
    "loadingRecords": "Ladowanie...",
    "processing":     "Obliczanie...",
    "search":         "Szukaj:",
    "zeroRecords":    "Nie znaleziono pasujacych produktow",
    "paginate": {
        "first":      "Pierwszy",
        "last":       "Ostatni",
        "next":       "Nastepne",
        "previous":   "Poprzednie"
    },
    "aria": {
        "sortAscending":  ": aktywuj by sortowac kolumnę a-z",
        "sortDescending": ": aktywuj by sortowac kolumnę z-a"
    }
}
    } );
        }); 
        $(document).ready(function(){
          
       $('label').css("color","black");
       $('label').css("font-weight","bold");
       $('option').css("font-weight","bold");
        });
</script>  
@stop