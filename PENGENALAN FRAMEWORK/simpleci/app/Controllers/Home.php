<?php

namespace App\Controllers;

class Home extends BaseController
{
    public function index()
    {
        return view('Home');
    }
    public function contact()
    {
        return view('contact');
    }
    public function about()
    {
        return view('about');
    }
}
