<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Manifestation extends Model
{
    use HasFactory;
    protected $table = 'MANIFESTATION';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';



}
