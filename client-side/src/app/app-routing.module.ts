import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from './main-page/main-page.component';
import { ChatPageComponent } from './chat-page/chat-page.component';

const routes: Routes = [
  { path: 'main', component: MainPageComponent },
  { path: 'chats', component: ChatPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
export const routingComponents = [MainPageComponent, ChatPageComponent];
