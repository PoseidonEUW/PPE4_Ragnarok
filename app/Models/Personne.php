<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Personne extends Model
{
    use HasFactory;
    protected $table ='PERSONNE';

    protected $fillable = [
        'NOMPERSONNE', 'PRENOMPERSONNE', 'EMAILPERSONNE',
    ];
    protected $primaryKey = 'IDPERSONNE';


}
