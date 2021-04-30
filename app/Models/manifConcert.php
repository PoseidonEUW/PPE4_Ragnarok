<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class manifConcert extends Model
{
    use HasFactory;
    protected $table = 'manifConcert';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';
}
