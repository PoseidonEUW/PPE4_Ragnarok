<?php

namespace App\Http\Controllers;
use App\Models\Avis;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class AvisController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Contracts\Foundation\Application|\Illuminate\Contracts\View\Factory|\Illuminate\Contracts\View\View|\Illuminate\Http\Response
     */
    public function index()
    {
        $avis = Avis::join('users','avis.IDPERSONNE','=','users.id')
            ->join('personne','users.id','=','personne.IDPERSONNE')
            ->where('personne.IDPERSONNE', Auth::id())
            ->get();

        return view('avis',[
            'avis'=>$avis

        ]);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\RedirectResponse
     */
    public function store(Request $request)
    {

        if(Auth::check()){


            $request->validate([
                'noteavis' => 'required|numeric|min:1|max:5',
                'libelle'=>'required|max:500',
            ],
            [
                'noteavis.required' => 'Trop Trop, doucement paapi!',
                'libelle.required' => 'Trop Trop, doucement paapi!',

            ]
            );
            try {
                $avis = Avis::create([
                    'IDMANIF' => $request->input('idmanif'),
                    'IDPERSONNE' => $request->input('idpersonne'),
                    'NOTEAVIS' => $request->input('noteavis'),
                    'LIBELLEAVIS' => $request->input('libelle'),


                ]);
                return redirect()->back()->with('message', 'Votre avis est en attente !');
            }catch (\Exception $e) {
                return redirect()->back()->with('message', 'Vous avez déjà donné votre avis sur cette manifestation !');
            }
        }

    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
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
