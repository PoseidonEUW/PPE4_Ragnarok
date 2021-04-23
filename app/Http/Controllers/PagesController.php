<?php

namespace App\Http\Controllers;

use App\Models\Artistes;
use Illuminate\Http\Request;

class PagesController extends Controller
{
    public function index(){
        return view('home');
    }
    public function aboutus(){
        return view('about-us');
}
public function artistes(){
    //Select * from Artistes
    $artistes = Artistes::join('personne','artistes.IDPERSONNE','=','personne.IDPERSONNE')
        ->get();

    return view('artistes',[
        'artistes'=>$artistes

    ]);
}
}
