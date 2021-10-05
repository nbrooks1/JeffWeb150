



describe('Getting Shows', () => {
    it('Can Find the Link', () => {
       cy.visit('http://localhost:1337/');
        cy.get('[data-nav-link-shows]').click();
        cy.url().should('include', '/Shows');
    });

    it('Can Get Details', () => {
        cy.visit('http://localhost:1337/Shows');
        cy.get('[data-shows-details-link="1"]').click();
        cy.url().should('include', "/Details")
    })
});