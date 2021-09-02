import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ASSETService } from '../shared/asset.service';
import { Router } from '@angular/router';
import { Constants } from '../Helper/constants';
import { ThrowStmt } from '@angular/compiler';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  public loginForm=this.formBuilder.group({
    email:['',[Validators.email,Validators.required]],
    password:['',Validators.required]
  })

  constructor(private formBuilder:FormBuilder,private assetservice:ASSETService,private router:Router) { }

  ngOnInit(): void {
  }

  onSubmit()
  {
    
    let email=this.loginForm.controls["email"].value;
    let password=this.loginForm.controls["password"].value;
    console.log("On Submit");
    this.assetservice.login(email,password).subscribe((data:any)=>{
      if(data.responseCode==1)
      {
        
        localStorage.setItem(Constants.USER_KEY,JSON.stringify(data.dateSet));
        this.router.navigate(["/manager"]);
        
      }
      else
      {
        alert(data.responseMessage);
      }
console.log("Response=",data);
      
    },error=>{
      console.log("error",error);
    })
    this.loginForm.reset();
  }

}
