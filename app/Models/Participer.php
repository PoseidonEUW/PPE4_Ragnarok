<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Participer extends Model
{
    use HasFactory;
    protected $table ='participer';

    protected $fillable = [
        'IDMANIF', 'IDPERSONNE'
    ];
    public $timestamps = false;
    protected $primaryKey = ['IDMANIF','IDPERSONNE'];
    public function manifestation(){
        return $this->belongsTo(Manifestation::class,'IDMANIF','IDMANIF');
    }
    public function personnes(){
        return $this->belongsTo(Personne::class,'IDPERSONNE');
    }
}
