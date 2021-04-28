<?php

namespace App\Http\Controllers;

use App\Models\Avis;
use App\Models\Reservation;
use App\Models\Personne;
use App\Models\Manifestation;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;

class ReservationController extends Controller
{
    public function index(){
        $reservations = Reservation::join('manifestation','reservation.IDMANIF','=','manifestation.IDMANIF')
                                    ->join('personne','reservation.IDPERSONNE','=','personne.IDPERSONNE')
                                    ->where('reservation.IDPERSONNE', Auth::id())
                                ->get();
        $avis = Avis::join('reservation','avis.IDPERSONNE','=','reservation.IDPERSONNE')
            ->where('avis.IDPERSONNE',Auth::id())
        ->get();
        return view('reservations',[
            'reservations'=>$reservations,
            'avis'=>$avis,

        ]);

    }
    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Contracts\Foundation\Application|\Illuminate\Contracts\View\Factory|\Illuminate\Contracts\View\View|\Illuminate\Http\Response
     */
   public function show($id){

   }
    public function create($id)
    {
        $reservation = Reservation::join('manifestation','reservation.IDMANIF','=','manifestation.IDMANIF','personne','reservation.IDPERSONNE','=','personne.IDPERSONNE')
            ->where('reservation.IDREFRESERVATION',$id);
        return view('avis')->with('reservation',$reservation);
    }
public function delete($id){
       $reservation = Reservation::find($id)->first();
       $reservation->delete();
    return redirect()->back();
}
}
