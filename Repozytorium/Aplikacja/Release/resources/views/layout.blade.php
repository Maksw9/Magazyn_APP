<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <title>Magazyn</title>

        <!-- Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Raleway:100,600" rel="stylesheet" type="text/css">

        <!-- JS -->      

        <script language="JavaScript" type="text/javascript" src="{{ URL::asset('/js/jquery-3.1.1.min.js') }}"></script>
        <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
        <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
        <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>

        <!-- Styles -->
        <link rel="stylesheet" href="{{ URL::asset('css/bootstrap.min.css') }}" type="text/css">
        <link rel="stylesheet" href="{{ URL::asset('css/style.css') }}" type="text/css">
    </head>
    <body>
      
        <div class="flex-center position-ref full-height">
            <div class="content">
                <div class="title m-b-md">
                    {{ $title }}
                </div>

                <div class="links">
                    <a href="/">Strona glowna</a>
                    <a href="/produkt/dodaj">Dodaj produkt</a>
                    <a href="/produkt/historia">Historia operacji</a>
                    <a href="/inwent">Inwentaryzacja</a> / <a href="/inwent/historia">Historia</a> 
                </div>
            </div>
        
        @yield('content')

    </body>
</html>
