<?php

namespace App\Http\Controllers;

use App\Http\Requests\StoreReservationRequest;
use App\Models\Avis;
use App\Models\manifAtelier;
use App\Models\manifConcert;
use App\Models\manifConference;
use App\Models\manifDebat;
use App\Models\Manifestation;
use App\Models\Reservation;
use App\Models\Debat;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Str;

class ManifestationController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Contracts\Foundation\Application|\Illuminate\Contracts\View\Factory|\Illuminate\Contracts\View\View|\Illuminate\Http\Response
     */
    public function index()
    {
        //Select * from Manifestation
        $manifestations = Manifestation::join('lieu','manifestation.IDLIEU','=','lieu.IDLIEU')
            ->join('festival','manifestation.ANNEEFESTIVAL','=','festival.ANNEEFESTIVAL')
            ->join('viser','manifestation.IDMANIF','=','viser.IDMANIF')
            ->join('public','viser.IDPUBLIC','=','public.IDPUBLIC')
            ->get();
        $manifAtelier = manifAtelier::join('manifestation','manifAtelier.IDMANIF','=','manifestation.IDMANIF')->get();
        $manifConcert = manifConcert::join('manifestation','manifConcert.IDMANIF','=','manifestation.IDMANIF')->get();
        $manifConference = manifConference::join('manifestation','manifConference.IDMANIF','=','manifestation.IDMANIF')->get();
        $manifDebat = manifDebat::join('manifestation','manifDebat.IDMANIF','=','manifestation.IDMANIF')->get();
        $avis = Avis::select( 'avis.IDMANIF', DB::raw( 'round(AVG(NOTEAVIS),2) AS moyenneavis'))
            ->join('manifestation','avis.IDMANIF','=','manifestation.IDMANIF')
            ->where('VALIDEAVIS','=','1')
            ->groupBy('manifestation.IDMANIF')
            ->get();

        return view('manifestations.index',[
            'manifestations'=>$manifestations,
            'manifAtelier'=>$manifAtelier,
            'manifConcert'=>$manifConcert,
            'manifConference'=>$manifConference,
            'manifDebat'=>$manifDebat,
            'avis'=> $avis,
        ]);



    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param \Illuminate\Http\Request $request
     * @return \Illuminate\Contracts\Foundation\Application|\Illuminate\Http\RedirectResponse|\Illuminate\Http\Response|\Illuminate\Routing\Redirector
     */
    public function store(Request $request)
    {
        if(Auth::check()){
            $request->validate([
                'quantiter' => 'numeric|min:1|max:4',
            ]);

            try {
    $reservation = Reservation::create([
        'IDMANIF'=>$request->input('idmanif'),
        'IDPERSONNE'=>$request->input('idpersonne'),
        'QUANTITERESERVATION'=>$request->input('quantiter'),

    ]);
//    Decrement
            return redirect()->back()->with('message', 'Votre place est reservée !');
            }catch (\Exception $e) {
                return redirect()->back()->with('message', 'Vous ne pouvez réserver que pour 4 personnes ou le nombre de places restantes est atteinte!');
            }

    }
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Contracts\Foundation\Application|\Illuminate\Contracts\View\Factory|\Illuminate\Contracts\View\View|\Illuminate\Http\Response
     */
    public function show($id)
    {
        $manifestation = Manifestation::join('lieu','manifestation.IDLIEU','=','lieu.IDLIEU');

        $avis = Avis::join('users','avis.IDPERSONNE','=','users.id')
            ->join('personne','users.id','=','personne.IDPERSONNE')
            ->where('IDMANIF',$id)
            ->where('VALIDEAVIS','=','1')
            ->paginate(4);
        $manifestation = $manifestation->find($id);

        return view('manifestations.show',["manifestation"=>$manifestation,"avis"=>$avis]);

    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
