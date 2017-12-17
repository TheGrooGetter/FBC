import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { SMService } from './services/sm.service';
import { TweenMax, TimelineMax, TweenConfig } from "gsap";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(protected smService: SMService){
      
  }
  
  ngOnInit(){
    try {
      this.smService.controller = new this.smService.ScrollMagic.Controller();
      var scene = new this.smService.ScrollMagic.Scene({
          triggerElement: '#test1'
        })
        .setTween('#div1',0.5,{backgroundColor: 'green', scale: 2.5})
        .addTo(this.smService.controller);

      var x = '';
    } catch(e){
      var err = e;
    }
      
  }
}
