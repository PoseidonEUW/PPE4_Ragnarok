<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class manifConference extends Model
{
    use HasFactory;
    protected $table = 'manifConference';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';
}
