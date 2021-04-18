<?php

namespace App\Models;

use App\Http\Controllers\PersonneController;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Artistes extends Model
{
    use HasFactory;
    protected $table = 'artistes';
    public $timestamps = false;
    protected $primaryKey = 'IDPERSONNE';

    public function personnes(){
        return $this->belongsTo(PersonneController::class);
    }


}
