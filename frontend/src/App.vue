<template>
  <v-app style="background-color: #ebebeb;">
    <HeaderPage />
    <v-main>
      <router-view />
    </v-main>
    <FooterPage />
  </v-app>
</template>

<script>
import FooterPage from './components/FooterPage.vue'
import HeaderPage from './components/HeaderPage.vue'

export default {
  name: 'App',
  components: {
    FooterPage,
    HeaderPage,
  },
  data: () => ({
    //
  }),
};
</script>
