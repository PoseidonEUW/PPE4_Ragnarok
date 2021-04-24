<?php

namespace App\Models;

use App\Http\Controllers\PersonneController;
use App\Http\Controllers\ManifestationController;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Avis extends Model
{
    use HasFactory;
    protected $table = 'avis';
    public $timestamps = false;
    protected $primaryKey = 'IDAVIS';
    protected $fillable = ['IDMANIF','IDPERSONNE','NOTEAVIS','LIBELLEAVIS'];

    public function personnes(){
        return $this->belongsTo(Personne::class,'IDPERSONNE');
    }
    public function manifestation(){
        $this->belongsTo(Manifestation::class,'IDMANIF');
    }

}
