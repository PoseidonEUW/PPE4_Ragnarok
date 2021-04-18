<?php

namespace App\Models;

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

}
