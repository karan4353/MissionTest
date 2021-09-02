import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ResponseModel } from '../Models/responseModel';
import {map} from 'rxjs/operators';
import { ResponseCode } from '../enums/responseCode';
import { pipe } from 'rxjs';
import { User } from '../Models/user';
import { Constants } from '../Helper/constants';

@Injectable({
  providedIn: 'root'
})
export class ASSETervice {
  

  constructor(private httpclient:HttpClient) { }
  baseurl:string="http://localhost:9475/api/";

  

  public login(email:string,password:string)
  {
    const body={
    Email:email,
    Password:password}
    return this.httpclient.post<ResponseModel>(this.baseurl+"User/Login",body);
  }

  public register(fullname:string,email:string,password:string)
  {
    const body={
    FullName:fullname,
    Email:email,
    Password:password,
    // Role:role
  }
    return this.httpclient.post<ResponseModel>(this.baseurl+"User/RegisterUser",body);
  }

    
}