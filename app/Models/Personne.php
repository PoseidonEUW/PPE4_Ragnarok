<?php

namespace App\Models;

use App\Http\Controllers\AvisController;
use App\Http\Controllers\PagesController;
use App\Http\Controllers\ReservationController;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Personne extends Model
{
    use HasFactory;
    protected $table ='personne';

    protected $fillable = [
        'NOMPERSONNE', 'PRENOMPERSONNE', 'EMAILPERSONNE',
    ];
    protected $primaryKey = 'IDPERSONNE';
    public function reservations(){
        return $this->hasMany(Reservation::class);
    }
    public function artistes(){
        return $this->hasMany(Artistes::class);
    }
    public function avis(){
        return $this->hasMany(Avis::class);
    }
    public function participer(){
        return $this->hasMany(Participer::class);
    }
}
