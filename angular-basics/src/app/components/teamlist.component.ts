import {Component} from '@angular/core'


@Component({
    selector: 'app-teamlist',
    templateUrl: 'teamlist.component.html'
})


export class TeamListComponent{
    isVisible:boolean=true
    title:string='Team ABBP'
    teamMembers:string[]=['Brunda','Anlin','Blessy','Priyanka']
    
    showHide(){
      this.isVisible=!this.isVisible;
    }
  
}