@extends('layout')
<?php $title = "Inwentaryzacja - podsumowanie"; 
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

<div class="container">
	<div class="row">
		@if (count($produkt) > 0)
		<table class="table table-striped">
			<thead>
				<tr>
					<th>ID produktu</th>
					<th>Poprzednia ilosc</th>
					<th>=></th>
					<th>Teraz</th>
					<th>=</th>
					<th>Podsumowanie</th>
				</tr>
			</thead>
			<tbody>
				<?php	$i=0; ?>
					@foreach($produkt as $prod)
					<tr>
						<td class="pid">{{$prod->pid}}</td>
						<td>{{$stare[$i]}}</td>
						<td>=></td>
						<td>{{$nowe[$i]}}</td>
						<td>=</td>
						<td>{{$roznica[$i]}}</td>
					</tr>
					<?php $i++;?> @endforeach
			</tbody>
		</table>
		<div class="form-group">

			<a href="/inwent"><button type="button" class="btn btn-default">Wróć</button></a>
		</div>
		@else
		<p class="text-center">
			Nie dokonano żadnych zmian.
			<div class="form-group">

				<a href="/inwent"><button type="button" class="btn btn-default">Wróć</button></a>
			</div>
		</p>
		@endif
	</div>
</div>

@stop