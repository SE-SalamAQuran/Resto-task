import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainPageComponent } from './main-page/main-page.component';
import { ChatPageComponent } from './chat-page/chat-page.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { WelcomeComponent } from './welcome/welcome.component';
const routes: Routes = [
  { path: 'main', component: MainPageComponent, pathMatch: 'full' },
  { path: 'chats', component: ChatPageComponent },
  { path: 'home', component: WelcomeComponent, pathMatch: 'full' },
  { path: '', redirectTo: '', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
export const routingComponents = [MainPageComponent, ChatPageComponent];
