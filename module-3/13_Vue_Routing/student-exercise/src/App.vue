<template>
  <div id="app">
    <nav>
    <router-link v-bind:to="{name: 'Home'}" />
    <router-link v-bind:to="{name: 'MyBooks'}" />
    </nav>
    <router-view />
  </div>
</template>

<script>
export default {
  name: 'app'
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin: 60px;
}
</style>
