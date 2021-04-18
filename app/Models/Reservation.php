<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Reservation extends Model
{
    use HasFactory;
    protected $table = 'reservation';
    protected $fillable = [
        'IDMANIF', 'IDPERSONNE','QUANTITERESERVATION'
    ];
    public $timestamps = false;
    protected $primaryKey = 'REFRESERVATION';
    public function manifestation(){
    $this->belongsTo(Manifestation::class);
    }
    public function user(){
        return $this->belongsTo(Personne::class);
    }
}
