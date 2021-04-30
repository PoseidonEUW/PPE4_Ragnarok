<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class manifDebat extends Model
{
    use HasFactory;
    protected $table = 'manifDebat';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';
}
