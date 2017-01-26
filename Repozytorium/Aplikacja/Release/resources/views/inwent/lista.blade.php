@extends('layout')
<?php $title = "Inwentaryzacja";
$erIndex=0; // indeks błędów $loop->index nie działa
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
@endif
<form id="forma" action="{{ url('/') }}/inwent/podsumowanie" method="post">
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
                    <th>Ilosc</th>
                    <th>Typ</th>
                    <th>Model</th>
                    <th>Rozmiar</th>
                    <th>Wiecej</th>
                </tr>
            </thead>
            <tbody>
            @foreach ($produkty as $produkt)
                <tr id="{{$produkt->id}}"
										@if($errors->has('ilosc.' . $erIndex))
										style="background:red"
										@endif
										>
                    <td scope="row">{{$produkt->id}}</td>
                    <td class="pid">{{ $produkt->pid }}</td>
                    <td><a href="/szczegoly/{{ $produkt->id }}">{{ $produkt->nazwa }}</a></td>
                    <td>{{ $produkt->producent }}</td>
                    <td>{{ $produkt->aleja }}</td>
                    <td>{{ $produkt->box }}</td>
                    <td>{{ $produkt->pozycja }}</td>
                    <td><input type="number" class="form-control" style="width:80%;" name="ilosc[]" 
											<?php
										if(!empty(old('ilosc.' . $erIndex)))
											echo "value=\"" . old('ilosc.' . $erIndex) . "\"";
															 else{
											if(empty($remem))
											 echo "value=\"" . $produkt->ilosc . "\"";
											else{
												foreach($remem as $rem)
												{
													if($rem->id == $produkt->id)
													echo "value=\"" . $rem->ilosc . "\"";
												}
													
											}
															 }
											?>
											></td>
                    <td>{{ $produkt->typ }}</td>
                    <td>{{ $produkt->model }}</td>
                    <td>{{ $produkt->rozmiar }}</td>
                    <td><a href="/inwent/historia/{{ $produkt->id }}">Historia inwentaryzacji produktu</a></td>
                    <td><input style="visibility:hidden" type="checkbox"></td>
                </tr>
							<?php $erIndex++;?>
            @endforeach
							<tr>
                    <td ></td>
                    <td ></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td> </td>
                    <td>
											<input type="hidden" name="zapamietaj" value="{{$zapamietane}}"/>
								<input type="submit" class="btn btn-default btn-lg btn-block zapamietajButton" style="width:80%;" name="subm" value="Cofnij zmiany" /><br/>
											@if(!$zapamietane)
											<button type="button" class="btn btn-default btn-lg btn-block" onclick="showSave()"  name="subm" style="width:80%;">
												Zapamiętaj
											</button><br/>
											@else
											 <button  type="button" class="btn btn-default btn-lg btn-block" style="width:80%;" onclick="showSave()">
												 Nadpisz
											</button><br/>
											@endif
											<a onclick="return clicked();"><input type="submit" class="btn btn-primary btn-lg btn-block" name="subSave" style="width:80%;" value="Zapisz"></td></a>
                    <td></td>
                    <td></td>
                    <td></td>
								<td></td>
								<td></td>
                </tr>
            </tbody>
        </table>
</form>
@if($zapamietane && (url()->current() == (url('/') . "/inwent")))
<!-- Popup, gdy sa zapamietane wartosci -->
<div class="modal fade in" role="dialog" id="myModal">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" style="font-weight:bold">Wybierz akcje na elemencie.</h4>
      </div>
      <div class="modal-body">
        <p>Wykryto wczesniejszy zapisany stan inwentaryzacji w systemie. Co chcesz zrobic?</p>
      </div>
      <div class="modal-footer form-inline">
				
  <div class="form-group">
				<form action="{{url('/')}}/inwent" method="post">
        <input type="submit" class="btn btn-default" name="cancelAction" onclick="hideModal()" value="Anuluj" />
				</form>
				</div><div class="form-group">
				<form action="{{url('/')}}/inwent/load" method="get">
        <input type="submit" class="btn btn-primary" value="Wczytaj"/>
				</form>
				</div>
				
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

@endif

<div class="modal fade" role="dialog" id="butSave">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" style="font-weight:bold">Wybierz akcje na elemencie.</h4>
      </div>
      <div class="modal-body">
				@if(!$zapamietane)
				<p>
					Czy na pewno chcesz to zrobić?
				</p>
				@else
        <p>Wykryto wczesniejszy zapisany stan inwentaryzacji w systemie. Czy chcesz nadpisać?</p>
  			@endif    
	</div>
      <div class="modal-footer form-inline">
				
  <div class="form-group">
        <button type="button" class="btn btn-default" data-dismiss="modal">Anuluj</button>
				</div><div class="form-group">
        <input type="button" class="btn btn-primary zapamietajButton" value="
																																						 @if(!$zapamietane)
																																						 Zapisz
																																						 @else
																																						 Nadpisz
																																						 @endif"/>
				</div>
				
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<script>
	function clicked() {
//     return confirm('Czy na pewno chcesz to zrobić?');
		$('#ModalSave').modal('show')
}
	function showSave(){
		$('#butSave').modal('show');
		return;
	}
	function hideModal(){
		$('#myModal').modal('hide');
	}
$(function() {
  $(".zapamietajButton").click(function() {
    $('#forma').attr('action', '{{ url('/') }}/inwent/remember');
		$('#forma').submit();
  });
});
	
$("tr").click(function() {
    var checkbox = $(this).find("input[type='checkbox']");
		checkbox.attr('checked', !checkbox.attr('checked'));
});
	$(window).load(function()
{
		@if(!empty(old('subSave')))
    $('#myModal').modal('hide');
		@else
    $('#myModal').modal('show');
		@endif
});
</script>
@stop