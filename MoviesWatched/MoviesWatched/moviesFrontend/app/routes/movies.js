import Route from '@ember/routing/route';
import {hash} from 'rsvp';
export default Route.extend({
    model() {
        return hash({
          movies: this.store.findAll('movie'),
          users: this.store.findAll('user'),
        });
      },
    
      setupController(controller, models) {
        controller.set('movies', models.movies);
        controller.set('users', models.users);
      }
});
