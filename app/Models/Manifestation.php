<?php

namespace App\Models;

use App\Http\Controllers\AvisController;
use App\Http\Controllers\ReservationController;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Manifestation extends Model
{
    use HasFactory;
    protected $table = 'manifestation';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';
    protected $dates = ['DATEMANIF', 'HORAIREDEBUTMANIF'];

    public function reservations(){
        return $this->hasMany(Reservation::class);
    }
    public function avis(){
        return $this->hasMany(Avis::class);
    }
    public function participer(){
        return $this->hasMany(Participer::class);
    }


}
