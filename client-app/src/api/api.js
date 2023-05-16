import axios from 'axios';

axios.get('/api/products')
  .then(response => {
    console.log(response.data);
  })
  .catch(error => {
    console.error('Error fetching data: ', error);
  });