<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class manifAtelier extends Model
{
    use HasFactory;
    protected $table = 'manifAtelier';
    public $timestamps = false;
    protected $primaryKey = 'IDMANIF';
}
