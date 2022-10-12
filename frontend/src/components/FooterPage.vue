<template>
  <v-footer dark padless>
    <v-card flat tile class="lighten-1 white--text text-center" width="100%">
      <v-card-text>
        {{ new Date().getFullYear() }} | <span>Douglas Oliveira</span>
        <v-btn class=" white--text" icon>
          <a href="https://www.linkedin.com/in/douglas-d-oliveira/" style="text-decoration: none; color: white;"
            target="_blank">
            <v-icon size="22px">
              mdi-linkedin
            </v-icon>
          </a>
        </v-btn>
        <v-btn class=" white--text" icon>
          <a href="https://github.com/doug-0" style="text-decoration: none; color: white;" target="_blank">
            <v-icon size="22px">
              mdi-github
            </v-icon>
          </a>
        </v-btn>
      </v-card-text>
    </v-card>
  </v-footer>
</template>

<script>
export default {
  data: () => ({}),
}
</script>