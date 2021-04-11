<?php

namespace App\Http\Controllers;

use App\Models\Personne;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class PersonneController extends Controller
{

    public function Check(Request $request) {
      $email = $request->input('EMAILPERSONNE');
      $personne = Personne::all()->where('EMAILPERSONNE',$email)->first();
      if ($personne == NULL){
        $idPersonne = PersonneController::store($request);
      }else{
          $idPersonne= $personne->IDPERSONNE;
      }
    return $idPersonne;

    }
    public function store(Request $request)
    {
        Personne::create($request->all());
        $email = $request->input('EMAILPERSONNE');
        $personne = Personne::all()->where('EMAILPERSONNE',$email)->first();
        return $personne->IDPERSONNE;
    }

}
