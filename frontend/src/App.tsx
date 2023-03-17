import { useState } from 'react'
import { Route, Routes } from 'react-router-dom'
import './App.css'

import Home from './pages/Home'
import Login from './pages/Login'
import PageNotFound from './pages/PageNotFound'
import Register from './pages/Register'

function App() {

  return (
    <>
      <Routes>

        <Route path="/" element={<Login />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />

        <Route path="/home" element={<Home />} />

        <Route path="*" element={<PageNotFound />} />

      </Routes>
    </>
  )
}

export default App
