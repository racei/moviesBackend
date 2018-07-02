import { helper } from '@ember/component/helper';

export function timeFormatter([params, ...rest]/*, hash*/) {
  let parts = params.split(':');
  let hours = parts[0];
  let minutes = parts[1];
  let seconds = parts[2];
  return `${hours}h ${minutes}m ${seconds}s`;
}

export default helper(timeFormatter);
