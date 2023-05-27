import React, { Component } from 'react';
import { Routes, Route } from "react-router-dom";
import { Login } from './components/Login';
import { ForgotPassword } from './components/ForgotPassword';
import { AdminDashboard } from './components/Admin/AdminDashboard';
import { UserDashboard } from './components/User/UserDashboard';
import './custom.css';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Routes>
                <Route index exact path='/' element={<Login />} />
                <Route exact path='/AdminPanel/*' element={<AdminDashboard />} />
                <Route exact path='/UserPanel/*' element={<UserDashboard />} />
                <Route exact path='/forgotPassword' element={<ForgotPassword />} />
            </Routes>
        );
    }
}
