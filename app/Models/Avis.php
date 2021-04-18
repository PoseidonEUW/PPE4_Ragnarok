<?php

namespace App\Models;

use App\Http\Controllers\PersonneController;
use App\Http\Controllers\ManifestationController;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Avis extends Model
{
    use HasFactory;
    protected $table = 'manifestation';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';
    protected $dates = ['DATEMANIF', 'HORAIREDEBUTMANIF'];

    public function personnes(){
        return $this->belongsTo(PersonneController::class);
    }
    public function manifestation(){
        $this->belongsTo(Manifestation::class);
    }

}
