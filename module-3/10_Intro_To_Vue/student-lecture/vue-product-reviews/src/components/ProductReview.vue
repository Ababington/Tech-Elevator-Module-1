<template>
  <div class="main">
      <h2>Product Reviews for {{bookName}}</h2>
      <p>{{description}}</p>
      <div v-for="review in reviews" v-bind:key="review.id">
          <h4>{{review.reviewer}}</h4>
          <div class ="rating">
              <img src="../assests/star.png" v-for="n in review.rating" v-bind:key="n">
          </div>
          <h3>{{review.title}}</h3>
          <p>{{review.review}}</p>
      </div>
  </div>
</template>

<script>
export default {
    name:'produc-review',
    data(){
        return{
            bookName:'Cigar Parties for Dummies',
            description: 'Host and plan the perfect cigar party for all of your squirrelly friends.',
            reviews:[
                {
                reviewer: "Henry Edwards",
                title: "Awesome book",
                review: "Good Book",
                ratign: 5
                },
                 {
                reviewer: "Mimi Malone",
                title: "Not a bad book",
                review: "eh",
                ratign: 3
                }
            ]
        }
    },
    computed:{
        numberOfFoveStarReviews(){
            return this.reviews.reduce((currentCount,review) =>{
                return currentCount + (review,ratign === 5);
            },0)
        }
    }
}
</script>

<style scoped>
div.main{
    margin: 1rem 0;
}
</style>