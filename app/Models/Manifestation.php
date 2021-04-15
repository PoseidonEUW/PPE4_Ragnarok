<?php

namespace App\Models;

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


}
